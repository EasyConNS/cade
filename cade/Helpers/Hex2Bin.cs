namespace cade.Helpers;

internal static class Hex2Bin
{
    public static void ConvertHexToBin(string hexFilePath, string binFilePath)
    {
        var data = new Dictionary<int, List<byte>>();
        var lines = File.ReadAllLines(hexFilePath);
        foreach (var line in lines)
        {
            if (line.StartsWith(":")) // 忽略非数据行（如起始行、结束行等）
            {
                var parts = line.Split(':')[1]; // 移除冒号并分割字符串
                int byteCount = Convert.ToInt32(parts.Substring(0, 2), 16);
                int address = Convert.ToInt32(parts.Substring(2, 4), 16);
                int recordType = Convert.ToInt32(parts.Substring(7, 2), 16);
                string dataHex = parts.Substring(9, byteCount * 2); // 获取数据部分
                byte[] dataBytes = Enumerable.Range(0, dataHex.Length)
                    .Where(x => x % 2 == 0)
                    .Select(x => Convert.ToByte(dataHex.Substring(x, 2), 16))
                    .ToArray();
                if (!data.ContainsKey(address)) data[address] = new List<byte>();
                data[address].AddRange(dataBytes);
            }
        }
        // 将数据写入BIN文件，按地址排序合并数据段
        using var binFile = File.Create(binFilePath);
        foreach (var kvp in data.OrderBy(x => x.Key)) // 按地址排序并合并数据段
        {
            binFile.Write(kvp.Value.ToArray(), 0, kvp.Value.Count);
        }
    }
}
