# C# Code Linting CLI

## 🚀 Quick Start

### Windows:
```cmd
# Check code style and syntax
check-cs.bat

# Auto-fix code style issues
fix-cs.bat
```

### Linux/Mac:
```bash
# Make scripts executable
chmod +x check-cs.sh fix-cs.sh

# Check code style and syntax
./check-cs.sh

# Auto-fix code style issues
./fix-cs.sh
```

## 📋 Commands

### `check-cs.bat` / `check-cs.sh`
- ✅ **Kiểm tra code style** với `dotnet format --verify-no-changes`
- ✅ **Kiểm tra syntax** với `dotnet build`
- ✅ **Không thay đổi code** (chỉ kiểm tra)
- ✅ **Hiển thị kết quả** chi tiết

### `fix-cs.bat` / `fix-cs.sh`
- 🔧 **Tự động sửa** code style issues
- 🔧 **Kiểm tra lại** sau khi sửa
- 🔧 **Kiểm tra syntax** với build
- 🔧 **Báo cáo** các issues không thể sửa tự động

## 🛠️ Tools Used

### dotnet-format
- **Chức năng**: Format C# code theo Microsoft standards
- **Files hỗ trợ**: .cs, .cshtml, .vb, .fs
- **Tự động sửa**: Indentation, spacing, line endings, etc.

### dotnet build
- **Chức năng**: Kiểm tra C# syntax và compile
- **Phát hiện**: Syntax errors, missing references, type errors
- **Configuration**: Release mode để kiểm tra nghiêm ngặt

## 📁 Files được kiểm tra

- ✅ **Controllers/*.cs** - C# controller files
- ✅ **Models/*.cs** - C# model files  
- ✅ **Views/*.cshtml** - Razor view files
- ✅ **Program.cs** - Main program file
- ✅ **Tất cả .cs files** trong project

## 🔧 Yêu cầu hệ thống

- **.NET 8.0 SDK** hoặc cao hơn
- **Windows**: PowerShell hoặc Command Prompt
- **Linux/Mac**: Bash shell

## 💡 Tips

1. **Chạy trước khi commit**:
   ```bash
   ./check-cs.sh  # Kiểm tra trước
   ./fix-cs.sh    # Sửa lỗi
   ./check-cs.sh  # Kiểm tra lại
   ```

2. **CI/CD Integration**:
   - Scripts này đã được tích hợp vào GitHub Actions
   - Tự động chạy khi có Pull Request

3. **IDE Integration**:
   - Visual Studio: Sử dụng built-in formatter
   - VS Code: C# extension với format on save

## 🆚 So sánh với ESLint

| Feature | ESLint (JS) | C# CLI |
|---------|-------------|--------|
| Check style | ✅ | ✅ (dotnet format) |
| Auto-fix | ✅ | ✅ (dotnet format) |
| Syntax check | ✅ | ✅ (dotnet build) |
| Easy commands | ✅ | ✅ (check-cs.bat) |
| CI/CD ready | ✅ | ✅ |

## 🐛 Troubleshooting

### "dotnet command not found"
- Cài đặt .NET 8.0 SDK từ: https://dotnet.microsoft.com/download

### "Permission denied" (Linux/Mac)
```bash
chmod +x check-cs.sh fix-cs.sh
```

### Build errors
- Kiểm tra syntax errors trong code
- Đảm bảo tất cả dependencies được restore
