namespace Print
{
	class Print {
		static void Main(string[] args) {
			string lua = "local lua = %s local py = %s local cs = %s local java = %s local c = %s local q = string.char(34) print(string.format(py, q .. lua .. q, q .. py .. q, q .. cs .. q, q .. java .. q, q .. c .. q))";
			string py = "lua = %s; py = %s; cs = %s; java = %s; c = %s; q = chr(34); print(cs %% (q + lua + q, q + py + q, q + cs + q, q + java + q, q + c + q))";
			string cs = "namespace Print {class Print {static void Main(string[] args) {string lua = %s; string py = %s; string cs = %s; string java = %s; string c = %s; char q = (char)34; System.Console.WriteLine(System.String.Format(java, q + lua + q, q + py + q, q + cs + q, q + java + q, q + c + q));}}}";
			string java = "public class Main {{public static void main(String[] args) {{String lua = {0}; String py = {1}; String cs = {2}; String java = {3}; String c = {4}; char q = 34; char nl = 10; System.out.printf(c, nl, q + lua + q, q + py + q, q + cs + q, q + java + q, q + c + q);}}}}";
			string c = "#include <stdio.h>\\nint main() {char lua[] = %s; char py[] = %s; char cs[] = %s; char java[] = %s; char c[] = %s; char q = 34; printf(lua, q + lua + q, q + py + q, q + cs + q, q + java + q, q + c + q); return 0;}";

			char q = (char)34;

			System.Console.WriteLine(System.String.Format(java, q + lua + q, q + py + q, q + cs + q, q + java + q, q + c + q));
		}
	}
}
