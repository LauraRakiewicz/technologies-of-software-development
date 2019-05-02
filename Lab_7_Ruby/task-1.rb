module InstanceModule
  def square
    self*self
  end
end

module ClassModule
  def sample(n)    
    raise ArgumentError,  "error"  unless n > 0   
    a = []
    n.times do
      a.push rand(10000000)
    end
    puts a
  end
end

class Integer
  include InstanceModule 
  extend ClassModule
  def factorial
    raise ArgumentError,  "error"  unless self > 0       
    self.downto(1).inject(:*)
  end
end

5.factorial