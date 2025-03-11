describe('todo', () => {
  it('should open the todo page', () => {
    cy.visit('http://localhost')
    cy.get('[data-cy=todo]').click()
    cy.title().should('eq', 'todo')
  })

  it('should add a todo', () => {
    cy.visit('http://localhost')
    cy.get('[data-cy=todo]').click()
    cy.get('[data-cy=add-todo]').type('new todo')
    cy.get('[data-cy=submit-todo]').click()
    cy.get('[data-cy=todo-list]').contains('new todo')
  })
})