using System;

var listToday = new List<string>{"Аня", "Боря", "Аня", "Вика", "Боря", "Гена"};
var hashToday = new HashSet<string>(listToday);
Console.WriteLine($"Кол-во клиентов сегодня: {hashToday.Count}");
int b = 1;
foreach (string a in hashToday)
{
  Console.WriteLine($"{b++}) {a}");
}
var listYestoday = new List<string>{"Аня", "Вика", "Дима", "Егор"};
var hashYestoday = new HashSet<string>(listYestoday);
var hashTopClient = new HashSet<string>(listToday);
var hashOnlyToday = new HashSet<string>(listToday);
hashTopClient.IntersectWith(hashYestoday);
hashOnlyToday.ExceptWith(hashYestoday);
Console.WriteLine("Общие посетители (и сегодня, и вчера): " + string.Join(", ", hashTopClient));
Console.WriteLine("Только сегодня: " + string.Join(", ", hashOnlyToday));
if (hashToday.Contains("Дима"))
{
  Console.WriteLine($"Да, Дима заходил сегодня");
}
else
{
  Console.WriteLine($"Нет, Дима не заходил сегодня");
}


/*I went to bed I was thinking about you
Ain't the same since I'm living without you
All the memories are getting colder
All the things that I wanna do over
I went to bed I was thinking about you
I wanna talk and laugh like we used to
When I see you in my dreams at night
It's so real but it's in my mind
And now
I guess
This is as good as it gets
Don't wake me
'Cause I don't wanna leave this dream
Don't wake me
'Cause I never seem to stay asleep enough
When it's you I'm dreaming of
I don't wanna wake up
I went to bed I was thinking about you
And how it felt when I finally found you
It's like a movie playing over in my head
Don't wanna look 'cause I know how it ends
All the words that I said that I wouldn't say
All the promises I made that I wouldn't break
It's last call, last song, last dance
'Cause I can't get you back, can't get a second chance
And now, I guess
This is as good as it gets
Don't wake me
'Cause I don't wanna leave this dream
Don't wake me
'Cause I never seem to stay asleep enough
When it's you I'm dreaming of
I don't wanna wake up
Don't wake me
We're together just you and me
Don't wake me
'Cause we're happy like we used to be
I know I've gotta let you go
But I don't wanna be alone
These dreams of you keep on growing stronger
It ain't a lot but it's all I have
Nothing to do but keep sleeping longer
Don't wanna stop cause I want you back
Don't wake me
'Cause I don't wanna leave this dream
Don't wake me
'Cause I never seem to stay asleep enough
When it's you I'm dreaming of
I don't wanna wake up
Don't wake me
We're together just you and me
Don't wake me
'Cause we're happy like we used to be
I know I've gotta let you go
But I don't wanna be alone
I went to bed I was thinking about you
Cause I don't wanna leave this dream
It ain't the same since I been here without you
Cause I never seem to stay asleep
I know I gotta let you go, I don't wanna wake up
*/