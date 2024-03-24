import { ComponentFixture, TestBed } from '@angular/core/testing';
import { HeaderComponent } from './header.component';

describe('HeaderComponent', () => {
  let component: HeaderComponent;
  let fixture: ComponentFixture<HeaderComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [HeaderComponent],
    }).compileComponents();

    fixture = TestBed.createComponent(HeaderComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
  
  it('should contain input text', () => {
    const fixture = TestBed.createComponent(HeaderComponent);
    component = fixture.componentInstance;
    component.pageTitle = "Test Title";
    component.strapLine = "A terribly exciting strapline";

    fixture.detectChanges();

    const compiled = fixture.nativeElement as HTMLElement;
    expect(compiled.querySelector('h1')?.textContent).toContain("Test Title");
    expect(compiled.querySelector('p')?.textContent).toContain("A terribly exciting strapline");
  });
});
