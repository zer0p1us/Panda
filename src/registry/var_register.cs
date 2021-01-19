using System;
using System.Collections.Generic;

namespace Panda {

    class var_register{

        /// <summary>
        /// variable name is the key and variable value is the value
        /// </summary>
        private Dictionary<string, dynamic> P_var = new Dictionary<string, dynamic>();

        /// <summary>
        /// variable register object
        /// </summary>
        public var_register() {
        }

        /// <summary>
        /// create variable
        /// </summary>
        /// <param name="var_name">name of new variable</param>
        /// <param name="var_value">value of new variable</param>
        public void set_variable(string var_name, dynamic var_value) {
            P_var.Add(var_name, var_value);
        }

        /// <summary>
        /// get variable value
        /// </summary>
        /// <param name="var_name"> the name of the variable </param>
        /// <returns>dynamic variable value</returns>
        public dynamic get_variable(string var_name) {
            try {
                dynamic var_value;
                P_var.TryGetValue(var_name, out var_value);
                return var_value;
            }catch (KeyNotFoundException) {
                return null;
            }
        }
    }

}