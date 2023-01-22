// https://leetcode.com/problems/keys-and-rooms/submissions/882880468/
public class Solution {
    public bool CanVisitAllRooms(IList<IList<int>> rooms) {
        var RoomToVisit = new Queue<int>(new[] { 0 });
        var RoomVisited = new HashSet<int>();
        while (RoomToVisit.Count > 0)
        {
            int n = RoomToVisit.Dequeue();
            RoomVisited.Add(n);
            for (int m = 0; m < rooms[n].Count; m++)
            {
                int v = rooms[n][m];
                if (RoomVisited.Contains(v) == false && RoomToVisit.Contains(v) == false)
                    RoomToVisit.Enqueue(v);
            }
        }
        return RoomVisited.Count == rooms.Count ? true : false;
    }
}
