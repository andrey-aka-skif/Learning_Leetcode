namespace problem_008_string_to_integer_atoi;

public class Solution
{
    public int MyAtoi(string s)
    {
        return MyAtoiAttempt2(s);
    }

    public int MyAtoiAttempt1(string s)
    {
        const int SPACE_ASCII_CODE = 32;
        const int PLUS_ASCII_CODE = 43;
        const int MINUS_ASCII_CODE = 45;
        const int ZERO_ASCII_CODE = 48;
        const int NINE_ASCII_CODE = 57;

        const int ASCII_SHIFT = 48;
        const int DIGIT_FACTOR = 10;

        bool isStarted = false;
        int sign = 1;
        long value = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (!isStarted)
            {
                // что делать с лидирующими нулями?...

                if (s[i] == SPACE_ASCII_CODE)
                    continue;

                if (s[i] == PLUS_ASCII_CODE)
                {
                    isStarted = true;
                    continue;
                }

                if (s[i] == MINUS_ASCII_CODE)
                {
                    isStarted = true;
                    sign = -1;
                    continue;
                }

                if (s[i] < ZERO_ASCII_CODE || s[i] > NINE_ASCII_CODE)
                    break;

                isStarted = true;
                value = s[i] - ASCII_SHIFT;
            }
            else
            {
                if (s[i] < ZERO_ASCII_CODE || s[i] > NINE_ASCII_CODE)
                    break;

                value *= DIGIT_FACTOR;
                value += s[i] - ASCII_SHIFT;
            }

            if (sign * value > int.MaxValue)
                return int.MaxValue;

            if (sign * value < int.MinValue)
                return int.MinValue;
        }

        return (int)(sign * value);
    }

    public int MyAtoiAttempt2(string s)
    {
        int result = 0;
        int res = 0b_0000_0000_0000_0000;
        bool isStarted = false;

        for (int i = 0; i < s.Length; i++)
        {

        }

        throw new NotImplementedException();
    }
}
