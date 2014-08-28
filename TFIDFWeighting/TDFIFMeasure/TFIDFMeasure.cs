/*
 * tf/idf implementation 
 * Author: Thanh Dao, thanh.dao@gmx.net
 */
using System;
using System.Collections;
using System.Collections.Generic;
using Preprocessing.TDFIFMeasure;


namespace ServiceRanking
{



	/// <summary>
	/// Summary description for TF_IDFLib.
	/// </summary>
	public class TFIDFMeasure
	{
        private List<string[]> _docs;
		private string[][] _ngramDoc;
		private int _numDocs=0;
		private int _numTerms=0;
		private ArrayList _terms;
		private int[][] _termFreq;
		private float[][] _termWeight;
		private int[] _maxTermFreq;
		private int[] _docFreq;


        private static string[] ArrayListToArray(ArrayList arraylist)
        {
            string[] array = new string[arraylist.Count];
            for (int i = 0; i < arraylist.Count; i++) array[i] = (string)arraylist[i];
            return array;
        }

        public List<string[]> Docs 
        { 
            get
            {
                return _docs;
            }
            set 
            {
                _docs = value;
            }
        }


        public ArrayList Terms
        {
            get
            {
                return _terms;
            }
            set
            {
                _terms = value;
            }
        }

        public float[][] TermWeight
        {
            get
            {
                return _termWeight;
            }
            set
            {
                _termWeight = value;
            }
        }


		private IDictionary _wordsIndex=new Hashtable() ;

        public TFIDFMeasure(List<string[]> documents)
		{
			_docs = documents;
			_numDocs = documents.Count ;
			Process();
		}

		private void GeneratNgramText()
		{
			
		}

        private ArrayList GenerateTerms(List<string[]> docs)
		{
			ArrayList uniques=new ArrayList() ;
			_ngramDoc=new string[_numDocs][] ;
			for (int i=0; i < docs.Count ; i++)
			{
                string[] words = docs[i];
                
                for (int j = 0; j < words.Length; j++)
                {
                    if (!uniques.Contains(words[j]))
                    {
                        uniques.Add(words[j]);
                    }
                }
								
			}
			return uniques;
		}
		


		private static object AddElement(IDictionary collection, object key, object newValue)
		{
			object element=collection[key];
			collection[key]=newValue;
			return element;
		}

		private int GetTermIndex(string term)
		{
			object index=_wordsIndex[term];
			if (index == null) return -1;
			return (int) index;
		}

		public void Process()
		{
			_terms=GenerateTerms (_docs );
			_numTerms=_terms.Count ;

			_maxTermFreq=new int[_numDocs] ;
			_docFreq=new int[_numTerms] ;
			_termFreq =new int[_numTerms][] ;
			_termWeight=new float[_numTerms][] ;

			for(int i=0; i < _terms.Count ; i++)			
			{
				_termWeight[i]=new float[_numDocs] ;
				_termFreq[i]=new int[_numDocs] ;

				AddElement(_wordsIndex, _terms[i], i);			
			}
			
			GenerateTermFrequency ();
			GenerateTermWeight();			
				
		}
		
		private float Log(float num)
		{
			return (float) Math.Log(num) ;//log2
		}

		private void GenerateTermFrequency()
		{
			for(int i=0; i < _numDocs  ; i++)
			{								
				IDictionary freq=GetWordFrequency(_docs[i]);
				IDictionaryEnumerator enums=freq.GetEnumerator() ;
				_maxTermFreq[i]=int.MinValue ;
				while (enums.MoveNext())
				{
					string word=(string)enums.Key;
					int wordFreq=(int)enums.Value ;
                    int termIndex = GetTermIndex(word);

					_termFreq [termIndex][i]=wordFreq;
					_docFreq[termIndex] ++;

					if (wordFreq > _maxTermFreq[i]) _maxTermFreq[i]=wordFreq;					
				}
			}
		}
		

		private void GenerateTermWeight()
		{			
			for(int i=0; i < _numTerms   ; i++)
			{
				for(int j=0; j < _numDocs ; j++)				
					_termWeight[i][j]=ComputeTermWeight (i, j);				
			}
		}

		private float GetTermFrequency(int term, int doc)
		{			
			int freq=_termFreq [term][doc];
			int maxfreq=_maxTermFreq[doc];			
			
			return ( (float) freq/(float)maxfreq );
		}

		private float GetInverseDocumentFrequency(int term)
		{
			int df=_docFreq[term];
			return Log((float) (_numDocs) / (float) df );
		}

		private float ComputeTermWeight(int term, int doc)
		{
			float tf=GetTermFrequency (term, doc);
			float idf=GetInverseDocumentFrequency(term);
			return tf * idf;
		}
		
		private  float[] GetTermVector(int doc)
		{
			float[] w=new float[_numTerms] ;
			for (int i=0; i < _numTerms; i++)											
				w[i]=_termWeight[i][doc];
			
				
			return w;
		}

		public float GetSimilarity(int doc_i, int doc_j)
		{
			float[] vector1=GetTermVector (doc_i);
			float[] vector2=GetTermVector (doc_j);

			return TermVector.ComputeCosineSimilarity(vector1, vector2) ;

		}
		
		private IDictionary GetWordFrequency(string[] input)
		{

            String[] words = input;
			Array.Sort(words);
			
			String[] distinctWords=GetDistinctWords(words);
						
			IDictionary result=new Hashtable();
			for (int i=0; i < distinctWords.Length; i++)
			{
				object tmp;
				tmp=CountWords(distinctWords[i], words);
				result[distinctWords[i]]=tmp;
				
			}
			
			return result;
		}				
				
		private string[] GetDistinctWords(String[] input)
		{				
			if (input == null)			
				return new string[0];			
			else
			{
				ArrayList list=new ArrayList() ;
				
				for (int i=0; i < input.Length; i++)
					if (!list.Contains(input[i])) // N-GRAM SIMILARITY?				
						list.Add(input[i]);

                return ArrayListToArray(list);
			}
		}
		

		
		private int CountWords(string word, string[] words)
		{
			int itemIdx=Array.BinarySearch(words, word);
			
			if (itemIdx > 0)			
				while (itemIdx > 0 && words[itemIdx].Equals(word))				
					itemIdx--;				
						
			int count=0;
			while (itemIdx < words.Length && itemIdx >= 0)
			{
				if (words[itemIdx].Equals(word)) count++;				
				
				itemIdx++;
				if (itemIdx < words.Length)				
					if (!words[itemIdx].Equals(word)) break;					
				
			}
			
			return count;
		}				
	}
}
