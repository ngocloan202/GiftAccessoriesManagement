CXX = g++
CXXFLAGS = -std=c++11 -Wall -Wextra
TARGET = quadratic_solver
SOURCE = quadratic_solver.cpp

all: $(TARGET)

$(TARGET): $(SOURCE)
	$(CXX) $(CXXFLAGS) -o $(TARGET) $(SOURCE)

clean:
	rm -f $(TARGET)

run: $(TARGET)
	./$(TARGET)

.PHONY: all clean run