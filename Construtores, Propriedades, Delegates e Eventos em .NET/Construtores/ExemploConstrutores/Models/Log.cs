namespace ExemploConstrutores.Models
{
    public class Log
    {

        private static Log _log
        
        public string PropriedadeLog{ get; set; }
        private Log()
        {
            
        }

        public static Log getInstance(){
            if(_log == null){
                _log = new Log;
            }
            return _log;
        }
    }
}