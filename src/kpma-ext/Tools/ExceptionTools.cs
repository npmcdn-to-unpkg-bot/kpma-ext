﻿using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;

namespace kpma_ext.Tools
{
	public static class ExceptionTools
    {
		/// <summary>
		/// Получить самое глубокое вложенное исключение
		/// </summary>
		/// <param name="ex">Исходное исключение</param>
		/// <returns>Искомое исключение</returns>
		public static Exception GetInnerException(Exception ex)
		{
			if (ex.InnerException == null)
			{
				return ex;
			}

			var ie = ex.InnerException;
			while (ie.InnerException != null)
			{
				ie = ie.InnerException;
			}

			return ie;
		}


		public static object GetExceptionMessage(Exception ex)
		{
			var exi = GetInnerException(ex);

			if (exi.Message.Contains("Violation of PRIMARY KEY constraint"))
			{
				return new ErrorMessage { Show = true, Text = "Запись с такими значениями уже существует." };
			}
			else
			{
				return new ErrorMessage { Show = true, Text = exi.Message };
			}
		}

		public static ErrorMessage GetErrorMessage(ModelStateDictionary state)
		{
			var ret = new ErrorMessage();
			ret.Show = true;

			ret.Text = state.Count.ToString();

			return ret;

		}
	}

	public class ErrorMessage {
		public bool Show { get; set; }
		public string Text { get; set; }
	}
}
