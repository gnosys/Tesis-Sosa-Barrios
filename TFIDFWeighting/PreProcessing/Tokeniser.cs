/*
Tokenization
Author: Thanh Ngoc Dao - Thanh.dao@gmx.net
Copyright (c) 2005 by Thanh Ngoc Dao.
*/

using System;
using System.Collections;
using System.Text.RegularExpressions;
using Preprocessing.Utils;


namespace ServiceRanking
{
	/// <summary>
	/// Summary description for Tokeniser.
	/// Partition string into SUBwords
	/// </summary>
	public class Tokeniser
	{
		public string[] Partition(string input)
		{
			Regex r=new Regex("([ \\t{}():;. \n])");			
			input=input.ToLower() ;

			String [] tokens=r.Split(input); 									

			ArrayList filter=new ArrayList() ;

			for (int i=0; i < tokens.Length ; i++)
			{
				MatchCollection mc=r.Matches(tokens[i]);
				if (mc.Count <= 0 && tokens[i].Trim().Length > 0)								
					filter.Add(tokens[i]) ;
			}
			
			return StringUtils.ArrayListToArray (filter);
		}
        		
	}
}
