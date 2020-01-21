#Main routine file
add_executable(enteral main.cpp)

find_package(Qt5Widgets)
target_link_libraries(enteral Qt5::Widgets Qt5::Core)