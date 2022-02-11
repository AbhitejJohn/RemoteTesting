#include "pch.h"
#include "CppUnitTest.h"

using namespace Microsoft::VisualStudio::CppUnitTestFramework;

namespace NativeUnitTestProject
{
	TEST_CLASS(NativeUnitTestProject)
	{
	public:
		
		TEST_METHOD(TestThatWorks)
		{
			Assert::AreEqual(1, 1);
		}

		TEST_METHOD(TestThatFails)
		{
			Assert::AreEqual(1, 2);
		}
	};
}
