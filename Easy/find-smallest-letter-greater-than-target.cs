for (int i = 0; i < letters.Length; i++)
{
    if (letters[i] > target)
        return letters[i];
}
return letters[0];
