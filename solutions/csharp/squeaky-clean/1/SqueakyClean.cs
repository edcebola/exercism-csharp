using System.Text;

public static class Identifier
{
	public static string Clean(string identifier)
	{
		bool makeNextUpper = false;
		StringBuilder final = new();
		int index = 0;
		foreach (char c in identifier)
		{
			if (c >= 'α' && c <= 'ω') continue;
			if (c == '-') makeNextUpper = true;
			else if (char.IsLetter(c) || c == ' ' || c == '_')
			{
				if (makeNextUpper)
				{
					char newC = char.ToUpper(c);
					final.Append(newC);
					makeNextUpper = false;
				}
				else final.Append(c);
			}
			else if (char.IsControl(c)) final.Append("CTRL");
			index++;
		}
		final.Replace(' ', '_');
		return final.ToString();
	}
}