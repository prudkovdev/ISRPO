using KnapsackSolverApp.Debugging;
using KnapsackSolverApp.Entities;
using System.Collections.Generic;

namespace KnapsackSolverApp
{
    public static class KnapsackSolver
    {
        /// <summary>
        /// Решает задачу о рюкзаке (0/1) методом динамического программирования.
        /// </summary>
        public static List<Item> Solve(List<Item> items, int maxWeight)
        {
            using (var timer = new ExecutionTimer("Решение задачи о рюкзаке"))
            {
                DebugLogger.LogItems(items, "Исходные данные:");
                DebugLogger.Log($"Начало решения задачи. Предметов: {items.Count}, Макс. вес рюкзака: {maxWeight}");

                if (items == null || items.Count == 0 || maxWeight <= 0)
                    return new List<Item>();

                int n = items.Count;
                // Создаем массив для хранения максимальной стоимости для каждого веса
                int[,] dp = new int[n + 1, maxWeight + 1];
                // Также будем хранить, брали ли предмет
                bool[,] keep = new bool[n + 1, maxWeight + 1];

                // Заполняем таблицу ДП
                for (int i = 1; i <= n; i++)
                {
                    var currentItem = items[i - 1];
                    for (int w = 0; w <= maxWeight; w++)
                    {
                        // Не берем текущий предмет
                        dp[i, w] = dp[i - 1, w];
                        keep[i, w] = false;

                        // Если можем взять (вес предмета не превышает w)
                        if (currentItem.Weight <= w)
                        {
                            int candidateCost = dp[i - 1, w - currentItem.Weight] + currentItem.Cost;
                            if (candidateCost > dp[i, w])
                            {
                                dp[i, w] = candidateCost;
                                keep[i, w] = true;
                            }
                        }
                    }
                }

                DebugLogger.Log($"Максимальная стоимость: {dp[n, maxWeight]}");

                // Восстанавливаем набор предметов
                List<Item> result = new List<Item>();
                int remainingWeight = maxWeight;
                for (int i = n; i > 0; i--)
                {
                    if (keep[i, remainingWeight])
                    {
                        var item = items[i - 1];
                        result.Add(item);
                        DebugLogger.Log($"Добавлен предмет: {item.Name}");
                        remainingWeight -= item.Weight;
                    }
                }

                DebugLogger.LogItems(result, "Результат решения");
                return result;
            }
        }
    }
}
