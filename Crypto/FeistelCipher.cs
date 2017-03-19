using System.Text;

namespace Crypto
{
    public static class FeistelCipher
    {
        private static byte[] _left; 
        private static byte[] _right;
        private static int _rounds;

        private static byte Func(byte[] left, int rKey) 
        {        
            byte result = (byte) ((left[0]+ rKey) %256);   
            return result;
        }     
        private static void ToChunks(byte[] array)
        {
            _left = new byte[array.Length/2];
            _right = new byte[array.Length/2];

            for (int i = 0; i < array.Length/2; i++)
            {            
                _left[i] += array[i];
                
            }
           //test
            for (int i = 0, j = array.Length/2 ; j < array.Length; i++, j++)
            {
                _right[i] = array[j];
                
            }
        }
        private static string IntoString(byte[] left, byte[] right)
        {
            string str = Encoding.UTF8.GetString(left) + Encoding.UTF8.GetString(right);
            return str;
        }
        public static string Encrypt(string str, int[] keys)
        {
            _rounds = keys.Length;
            if (str.Length % 2 != 0) str += " ";
            var strBytes = Encoding.UTF8.GetBytes(str);
            ToChunks(strBytes);

            for (int i = 0; i < _rounds; i++)
            {              
                var f = Func(_left, keys[i]); 
                if (i != _rounds-1)
                {               
                    var tmp = new byte[_left.Length];                 
                    for (int j = 0; j < _left.Length; j++)                  
                        tmp[j] = _left[j];                                                                                                               
                    for (int j = 0; j < _left.Length; j++)
                        _left[j] = (byte)(_right[j] ^ f);                 
                    _right = tmp;               
                }
                else
                {                  
                    for (int j = 0; j < _right.Length; j++)                  
                        _right[j] = (byte) (_right[j] ^ f);                 
                }
            }
            return IntoString(_left,_right);
        }
        public static string Decrypt(string str, int[] keys)
        {
            _rounds = keys.Length;
            if (str.Length % 2 != 0) str += " ";
            var strBytes = Encoding.UTF8.GetBytes(str);
            ToChunks(strBytes);
          
            for (int i = _rounds; i > 0; i--)
            {                                         
                var f = Func(_left, keys[i-1] ); 
                if (i != 1 )
                {              
                    var tmp = new byte[_left.Length];                                
                    for (int j = 0; j < _left.Length; j++) 
                        tmp[j] = _left[j];                   
                    for (int j = 0; j < _left.Length; j++) 
                        _left[j] = (byte)(_right[j] ^ f);                                                       
                    _right = tmp;                    
                }
                else
                {                
                    for (int j = 0; j < _right.Length; j++)
                        _right[j] = (byte)(_right[j] ^ f);                  
                }
            }
            return IntoString(_left, _right);
        }     
    }
}
