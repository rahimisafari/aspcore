using aspcore.Models;

namespace aspcore.Classes;
public class Bugs{
    public Bug[] sampleBugs={
        new Bug{id=1,name="bug 1",description="desc for bug 1",isDone=true},
        new Bug{id=2,name="bug 2",description="desc for bug 2",isDone=false},
        new Bug{id=3,name="bug 3",description="desc for bug 3",isDone=true},
        new Bug{id=4,name="bug 4",description="desc for bug 4",isDone=false},
        new Bug{id=5,name="bug 5",description="desc for bug 5",isDone=true},
    };
}