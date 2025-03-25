describe('todo', () => {
  beforeEach(() => {
    cy.visit('http://localhost')
    cy.get('[data-cy=todo]').click()
    cy.get('[data-cy=clear-todos]').click()
  })

  it('should open the todo page', () => {
    cy.title().should('eq', 'todo')
  })

  it('should add a todo', () => {
    cy.get('[data-cy=add-todo]').type('new todo')
    cy.get('[data-cy=submit-todo]').click()
    cy.get('[data-cy=todo-list]').contains('new todo')
  })

  it('should add two todos', () => {
    cy.get('[data-cy=add-todo]').type('new todo')
    cy.get('[data-cy=submit-todo]').click()
    cy.get('[data-cy=add-todo]').type('another todo')
    cy.get('[data-cy=submit-todo]').click()

    cy.get('[data-cy=todo-list]').contains('new todo')
    cy.get('[data-cy=todo-list]').contains('another todo')
  })
})