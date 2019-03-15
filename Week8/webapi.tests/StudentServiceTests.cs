using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;
using NUnit.Framework;
using FakeItEasy;
using FluentAssertions;
using Database.Entities;
using StudentBusinessRules;

public class StudenttServiceTests
{
    private StudentService _studentService; // System Under Test (SUT)
    private IStudentRepository _studentRepository; // Mock

    [SetUp]
    public void Setup()
    {
        _studentRepository = A.Fake<IStudentRepository>();

        _studentService = new StudentService(_studentRepository);
    }

    [Test]
    public void ShouldHaveSpecialStudent()
    {
        // Arrange
        A.CallTo(() => _studentRepository.GetAllStudents()).Returns(
            new List<Student> {
                new Student {
                    studentId = 1,
                    email_address = "john.smith@oit.edu"
                },
                new Student {
                    studentId = 2,
                    email_address = "mary.jones@oit.edu"
                }
            }
        );

        // Act
        var studentDtos = _studentService.GetAllStudents();

        // Assert (NUnit Assertions)
        Assert.That(studentDtos.Any(sdto => sdto.Special), Is.EqualTo(true));

        // Assert (FluentAssertions)
        //productDtos.Any(sdto => sdto.Special).Should().BeTrue();
    }

    [Test]
    public void ShouldReturnNoSpecialStudents()
    {
       // Arrange
        A.CallTo(() => _studentRepository.GetAllStudents()).Returns(
            new List<Student> {
                new Student {
                    studentId = 2,
                    email_address = "john.smith@oit.edu"
                },
                new Student {
                    studentId = 3,
                    email_address = "mary.jones@oit.edu"
                }
            }
        );

        // Act
        var studentDtos = _studentService.GetAllStudents();

        // Assert (NUnit Assertions)
        Assert.That(studentDtos.Any(sdto => sdto.Special), Is.EqualTo(false));

        // Assert (FluentAssertions)
        //productDtos.Any(sdto => sdto.Special).Should().BeFalse();
    }

    // [Test]
    // public void ShouldNotReturnProductsWithLowInventory()
    // {
    //     // Arrange
    //     A.CallTo(() => _productRepository.GetAllProducts()).Returns(
    //         new List<Product> {
    //             new Product {
    //                 Name = "product1",
    //                 Count = BusinessRules.lowInventoryCount + 1
    //             },
    //             new Product {
    //                 Name = "product2",
    //                 Count = BusinessRules.lowInventoryCount + 1
    //             }
    //         }
    //     );

    //     // Act
    //     var productDtos = _productService.GetAllProducts();

    //     // Assert (FluentAssertions)
    //     productDtos.Any(pdto => pdto.LowInventory).Should().BeFalse();
    // }

    // [Test]
    // public void ShouldReturnProductsWithLowInventory()
    // {
    //     // Arrange
    //     A.CallTo(() => _productRepository.GetAllProducts()).Returns(
    //         new List<Product> {
    //             new Product {
    //                 Name = "bike",
    //                 Count = 4
    //             },
    //             new Product {
    //                 Name = "product2",
    //                 Count = BusinessRules.lowInventoryCount - 1
    //             }
    //         }
    //     );

    //     // Act
    //     var productDtos = _productService.GetAllProducts();

    //     // Assert (FluentAssertions)
    //     productDtos.Single(pdto => pdto.LowInventory).Name.Should().Be("product2");
    // }
}