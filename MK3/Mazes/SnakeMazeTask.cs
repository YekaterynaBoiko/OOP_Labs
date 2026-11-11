namespace Mazes;

public static class SnakeMazeTask
{

    public static void MoveOut(Robot robot, int width, int height)
    {//i < height - 3 && 
        int i = 0;
        while (!robot.Finished)
        {
            if (i % 2 == 0) MoveRight(robot, width - 3);
            else MoveLeft(robot, width - 3);
            if (i < height - 4 && !robot.Finished) MoveDown(robot, 2);
            i++;
        }
    }// перевірку блоків з while і коли він дійшов то вийти з циклу
    //додати перевірку чи він пройшов, метод вниз

    public static void MoveDown(Robot robot, int stepCount) //зробити за аналогією moveright
    {
        for (int i = 0; i < stepCount; i++)
            robot.MoveTo(Direction.Down);
    }

    public static void MoveRight(Robot robot, int stepCount)
    {
        for (int i = 0; i < stepCount; i++)
            robot.MoveTo(Direction.Right);
    }

    public static void MoveLeft(Robot robot, int stepCount)
    {
        for (int i = 0; i < stepCount; i++)
            robot.MoveTo(Direction.Left);
    }
}