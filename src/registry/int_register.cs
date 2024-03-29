using System;
using System.Collections.Generic;

namespace Panda {

	public class int_register {

		/// <summary>
		///	variable name is the key adn the variable value is the integer variable
		/// </summary>
		private Dictionary<string, int> panda_int = new Dictionary<string, int>();

		/// <summary>
		///	integer variable register object
		/// </summary>
		public int_register(){

		}

		/// <summary>
		///	create interger variable
		/// </summary>
		/// <param name="int_name">name of new variable</param>
        /// <param name="int_value">value of new variable</param>
        public void setVariable(string int_name, int int_value) {
            if (isIntegerRegistered(int_name)){
                panda_int[int_name] = int_value;
            }else{
                panda_int.Add(int_name, int_value);
            }
        }

		/// <summary>
        /// get integer value
        /// </summary>
        /// <param name="int_name"> the name of the variable </param>
        /// <returns>dynamic variable value</returns>
        public int getVariable(string int_name) {
            if (isIntegerRegistered(int_name)){
                return panda_int[int_name];
            }else{
                Console.WriteLine("[warning]: integer variable " + int_name + " does not exist in the current context");
				return 0;
            }
        }

        //returns whether a given integer name is in the dictionary
        public bool isIntegerRegistered(string int_name){
            return panda_int.ContainsKey(int_name);
        }


	}

}
