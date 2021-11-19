using System;
/// <summary>
/// 計算階梯高度
/// 假設一層房子高度 280cm，那麼隨著階梯數愈多，每一階的高度就愈小
/// 我們希望一階的高度介於 15cm ~ 20cm，階數大約介於 14 ~ 18 階之間
/// </summary>

namespace ConsoleApp2
{
    class Steps
    {
        public static void MainStep()
        {
            int maxHeight = 280;
            int step = 1;
            decimal avgHeight = calcAvgHeight(maxHeight, step);
            runStep(maxHeight, step, avgHeight);
        }

        static bool runStep(int maxHeight, int step, decimal avgHeight)
        {
            if (avgHeight <= 15)
            {
                return true;
            }
            if (avgHeight <= 20)
            {
                Console.WriteLine($"Step: {step}, StepHeight: {avgHeight}");
            }
            if (avgHeight >= 15)
            {
                step++;
                avgHeight = calcAvgHeight(maxHeight, step);
                return runStep(maxHeight, step, avgHeight);
            }

            return true;
        }

        static decimal calcAvgHeight(int height, int step)
        {
            return (decimal)height / (decimal)step;
        }

    }
}
